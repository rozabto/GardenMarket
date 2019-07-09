using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace GardenMarket.SafeCharge
{
    public class SafeChargeService : ISafeChargeService
    {
        private readonly char[] HEXADECIMAL = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f' };
        private const string MESSAGE_DIGEST = "SHA256";
        private const string ENCODING = "UTF-8";
        private const string DATE_FORMAT = "yyyy-MM-dd.HH:mm:ss";
        private readonly string _merchantKey;

        public SafeChargeService(string merchantKey)
        {
            _merchantKey = merchantKey ?? throw new ArgumentNullException(nameof(merchantKey));
        }

        public string CreateRequest()
        {
            const string pppUrl = "https://ppp-test.safecharge.com/ppp/purchase.do?";

            var _params = ConstructParametersMap(ENCODING);
            var _paramsForChecksum = ConstructParametersMapForChecksum(ENCODING);
            string checksum = CalculateChecksum(_paramsForChecksum, _merchantKey, ENCODING);
            _params.Add("checksum", checksum);
            string encoded_params = EncodeParameters(_params, ENCODING);

            return pppUrl + encoded_params;
        }

        private string EncodeParameters(Dictionary<string, string> _params, string encoding)
        {
            var postData = new StringBuilder();
            foreach (var param in _params)
            {
                if (postData.Length != 0)
                {
                    postData.Append("&");
                }

                postData.Append(HttpUtility.UrlEncode(param.Key, Encoding.GetEncoding(ENCODING)));
                postData.Append("=");
                postData.Append(HttpUtility.UrlEncode(param.Value, Encoding.GetEncoding(ENCODING)));
            }

            return postData.ToString();
        }

        private Dictionary<string, string> ConstructParametersMap(string encoding)
        {
            var _params = new Dictionary<string, string>();

            string timestamp = DateTime.UtcNow.ToString(DATE_FORMAT);

            _params.Add("currency", "EUR");
            _params.Add("item_name_1", "5Test Product");
            _params.Add("item_number_1", "1");
            _params.Add("item_quantity_1", "1");
            _params.Add("item_amount_1", "50.00");
            _params.Add("numberofitems", "1");
            _params.Add("encoding", "utf-8");
            _params.Add("merchant_id", "4778151621448449994");
            _params.Add("merchant_site_id", "183073");
            _params.Add("time_stamp", "2019-07-08.09:55:50");
            _params.Add("version", "4.0.0");
            _params.Add("user_token_id", "niki4616@gmail.com");
            _params.Add("user_token", "auto");
            _params.Add("total_amount", "50.00");
            _params.Add("notify_url", "https://sandbox.safecharge.com/lib/demo_process_request/response.php");

            return _params;
        }

        private Dictionary<string, string> ConstructParametersMapForChecksum(string encoding)
        {
            var _params = new Dictionary<string, string>();

            string timestamp = DateTime.UtcNow.ToString(DATE_FORMAT);

            _params.Add("currency", "EUR");
            _params.Add("item_name_1", "5Test Product");
            _params.Add("item_number_1", "1");
            _params.Add("item_quantity_1", "1");
            _params.Add("item_amount_1", "50.00");
            _params.Add("numberofitems", "1");
            _params.Add("encoding", "utf-8");
            _params.Add("merchant_id", "4778151621448449994");
            _params.Add("merchant_site_id", "183073");
            _params.Add("time_stamp", "2019-07-08.09:55:50");
            _params.Add("version", "4.0.0");
            _params.Add("user_token_id", "niki4616@gmail.com");
            _params.Add("user_token", "auto");
            _params.Add("total_amount", "50.00");
            _params.Add("notify_url", "https://sandbox.safecharge.com/lib/demo_process_request/response.php");

            return _params;
        }

        private string CalculateChecksum(Dictionary<string, string> _params, string merchantKey, string encoding)
        {
            var allVals = new StringBuilder();
            allVals.Append(merchantKey);
            foreach (var param in _params)
            {
                allVals.Append(param.Value);
            }

            return GetHash(allVals.ToString(), encoding);
        }

        private string GetHash(string text, string charset)
        {
            byte[] bytes;
            using (var md = HashAlgorithm.Create(MESSAGE_DIGEST))
            {
                if (md == null)
                {
                    Console.Error.WriteLine("SHA256 implementation not found.");
                    return null;
                }

                byte[] encoded;
                try
                {
                    encoded = Encoding.GetEncoding(ENCODING).GetBytes(text);
                }
                catch (EncoderFallbackException ex)
                {
                    Console.Error.WriteLine("Cannot encode text into bytes: " + ex.Message);
                    return null;
                }

                bytes = md.ComputeHash(encoded);
            }

            // Output the bytes of the hash as a String (text/plain)
            var sb = new StringBuilder(2 * bytes.Length);
            for (int i = 0; i < bytes.Length; i++)
            {
                int low = bytes[i] & 0x0f;
                int high = (bytes[i] & 0xf0) >> 4;
                sb.Append(HEXADECIMAL[high]);
                sb.Append(HEXADECIMAL[low]);
            }
            return sb.ToString();
        }
    }
}