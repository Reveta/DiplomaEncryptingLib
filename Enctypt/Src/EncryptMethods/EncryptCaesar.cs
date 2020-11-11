using System;
using CryptManager;
using CryptManager.Interfaces;
using Enctypt.CryptResultContainers;
using Enctypt.Interfaces;

namespace Enctypt.EncryptMethods {
	public class EncryptCaesar : IEncryptor {
		public ICryptResult Encrypt(string message, EEncodinType type, IEncryptConfig config) {
			string configKey = config.Key;
			string result = "";
			foreach (char letter in message) {
				char cipher = Cipher(letter, Int32.Parse(configKey));
				result += cipher;
			}

			return new CryptResult() {CryptData = result, Key = configKey}; 
		}

		public static char Cipher(char ch, int key) {
			if (!char.IsLetter(ch)) {
				return ch;
			}

			char d = char.IsUpper(ch) ? 'A' : 'a';
			return (char) ((((ch + key) - d) % 26) + d);
		}
	}
}