using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RSA
{
   public class RSA
    {
        //Create a UnicodeEncoder to convert between byte array and string.
        UnicodeEncoding ByteConverter = new UnicodeEncoding();
        byte[] encryptedData;
        byte[] decryptedData;
        RSACryptoServiceProvider Rsa;

        public RSA(int size)
        {
            Rsa = new RSACryptoServiceProvider(size);

        }
        public Byte[] encryptText(String plainText)
        {
            byte[] dataToEncrypt = ByteConverter.GetBytes(plainText);
            //a boolean flag specifying no OAEP padding.
            encryptedData = Rsa.Encrypt(dataToEncrypt, true);
            return encryptedData;
        }

        public String decryptBytes(Byte[] encryptedData)
        {

            //encryptedData=ByteConverter.GetBytes(cryptedText);
            //a boolean flag specifying no OAEP padding.

            decryptedData = Rsa.Decrypt(encryptedData, true);

            return ByteConverter.GetString(decryptedData);
        }

        public XmlDocument getPrivateKey()
        {
            //Save the public key information to an RSAParameters structure.  
            RSAParameters RSAKeyInfo = Rsa.ExportParameters(true);

            String s = Rsa.ToXmlString(true);
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(s);

            XmlNodeList publicKey = xml.GetElementsByTagName("Modulus");
            XmlNodeList privateKey = xml.GetElementsByTagName("P");
            return xml;

        }
        public XmlDocument getPublicKey()
        {
            //Save the public key information to an RSAParameters structure.  
            RSAParameters RSAKeyInfo = Rsa.ExportParameters(true);

            String s = Rsa.ToXmlString(false);
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(s);

            XmlNodeList publicKey = xml.GetElementsByTagName("Modulus");
            XmlNodeList privateKey = xml.GetElementsByTagName("P");
            return xml;
        }

        public void SaveKeysToFile()
        {
            //private
           XmlNodeList publiKey = getPublicKey().GetElementsByTagName("Exponent");
        
            XmlNodeList privateKey = getPrivateKey().GetElementsByTagName("P");

        

            try
            {
                String FileName = "privatni.txt";
                File.WriteAllText(FileName, "-----BEGIN PRIVATE KEY-----");
                File.AppendAllText(FileName, privateKey[0].InnerXml);
                File.AppendAllText(FileName, "-----END PRIVATE KEY-----");

                String FileName1 = "javni.txt";
                File.WriteAllText(FileName1, "-----BEGIN PUBLIC KEY-----");
                File.AppendAllText(FileName1, privateKey[0].InnerXml);
                File.AppendAllText(FileName1, "-----END PUBLIC KEY-----");



            }
            catch (CryptographicException e)
            {
                Console.WriteLine("A Cryptographic error occurred: {0}", e.Message);
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("A file access error occurred: {0}", e.Message);
            }

        }



    }
}
