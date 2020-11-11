using CryptManager.Interfaces;

namespace CryptManager.Implementations.Caesar {
	public class EncryptConfigCaesar : IEncryptConfig {
		public string Key { get; set; }
	}
}