using System;
using CryptManager.Implementations.Caesar;
using CryptManager.Interfaces;

namespace CryptManager {
	public class EncryptHelper {
		private IEncryptConfig EncryptConfig { get; set; }
		private IKeyGenerator KeyGenerator { get; set; }
		
		public EncryptHelper SetEcryptType(EEncodinType type) {

			switch (type) {
				case EEncodinType.Caesar:
					this.EncryptConfig = new EncryptConfigCaesar();
					this.KeyGenerator = new KeyGeneratorCaesar();
					break;
				default:
					throw new ArgumentOutOfRangeException(nameof(type), type, null);
			}
			
			return this;
		}

		public IEncryptConfig GetConfigurator() {
			return this.EncryptConfig;
		}

		public IKeyGenerator GetKeyGenerator() {
			return this.KeyGenerator;
		}
	}
}