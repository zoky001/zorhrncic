using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;



namespace RSA
{
    public partial class Form1 : Form
    {
        //Create a UnicodeEncoder to convert between byte array and string.
        UnicodeEncoding ByteConverter = new UnicodeEncoding();
        byte[] encryptedData;
        byte[] decryptedData;
        
        // Create a new TripleDESCryptoServiceProvider object
        // to generate a key and initialization vector (IV).
        


        RSA RSA;
       TripleDes tDESalg;

        public Form1()
        {
            RSA = new RSA(4096);
            tDESalg = new TripleDes();

            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            printKeys();

         
            textBoxCrypted.Text = BitConverter.ToString(RSA.encryptText(textBoxEnter.Text));

            textBoxDecripted.Text =  RSA.decryptBytes(RSA.encryptText(textBoxEnter.Text));


            richTextBoxCrypt3DES.Text = BitConverter.ToString(tDESalg.EncryptText(textBoxEnter.Text));

            tDESalg.EncryptTextToFile3DES(textBoxEnter.Text);
            

 textBoxDECRIPY3DES.Text = tDESalg.DecryptTextFromFile3DES();

            tDESalg.SaveKeysToFile3DES();

            RSA.SaveKeysToFile();







        }

        private void printKeys() {
           

            XmlNodeList publicKey = RSA.getPublicKey().GetElementsByTagName("Modulus");
            XmlNodeList privateKey =RSA.getPrivateKey().GetElementsByTagName("P");

            text_RSA_PRIVATE.Text = privateKey[0].InnerXml;

            text_RSA_public.Text = publicKey[0].InnerXml;

            richTextBox_3DES.Text = BitConverter.ToString(tDESalg.get3DES().Key);
            richTextBoxVector.Text = BitConverter.ToString(tDESalg.get3DES().IV);


        }

        

    }
}
