using System;
using CryptManager;
using CryptManager.Interfaces;
using Enctypt.EncryptMethods;
using Enctypt.Interfaces;

namespace DiplomaEncodingLib {
	internal class Program {
		public static void Main(string[] args) {
			IEncryptor encryptor = new EncryptCaesar();
			EncryptHelper helper = new EncryptHelper().SetEcryptType(EEncodinType.Caesar);
			
			IEncryptConfig encryptConfig = helper.GetConfigurator();
			encryptConfig.Key = "1";
			
			ICryptResult cryptResult = encryptor.Encrypt("test", EEncodinType.Caesar, encryptConfig);
			
			Console.WriteLine("Encrypted data: " + cryptResult.CryptData);
			Console.WriteLine("Key: " + cryptResult.Key);
		}
	}
}