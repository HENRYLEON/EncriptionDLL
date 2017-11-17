using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestEncryption
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod()]
        public void EncryptarTest()
        {
            string result;
            string resultDes;
            Encryption.Encryption encryption = new Encryption.Encryption();
            result = encryption.Encryptar("prueba");
            resultDes = encryption.Decryptar(result);
            Assert.AreEqual(resultDes, "prueba");
        }

        [TestMethod()]
        public void DecryptarTest()
        {
            string result;
            Encryption.Encryption encryption = new Encryption.Encryption();
            result = encryption.Decryptar("Rxjw3FYWWxVXoLBfzBs5BlYzkJ3xhzfJp4xV5ZiqENcmM8wa0took0rsHT7HQ1Tt0usI5QL2QfSjPvu9Q/VqlUf1aiXt3KBpd/04eheProUE6soip0wE343qPMhD2kmX");
            Assert.AreEqual("prueba", result);
        }

        [TestMethod()]
        public void EncryptarTestFailure()
        {
            string result;
            Encryption.Encryption encryption = new Encryption.Encryption();
            result = encryption.Encryptar("prueba");
            Assert.AreNotEqual("/pDUAcmDArO5INGGInOzAfG6cYBl3xnxClbIpI1SyPb1CPEoVw6", result);
        }

        [TestMethod()]
        public void DecryptarTestFailure()
        {
            string result;
            Encryption.Encryption encryption = new Encryption.Encryption();
            result = encryption.Decryptar("Rxjw3FYWWxVXoLBfzBs5BlYzkJ3xhzfJp4xV5ZiqENcmM8wa0took0rsHT7HQ1Tt0usI59L2QfSjPvu9Q/VqlUf1aiXt3KBpd/14eheProUE6soip0wE343qPMhD2kmp");
            Assert.AreNotEqual("prueba", result);
        }
    }
}
