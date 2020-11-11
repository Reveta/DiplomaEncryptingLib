using CryptManager;
using CryptManager.Interfaces;

namespace Enctypt.Interfaces {
	public interface IEncryptor {
		ICryptResult Encrypt(string message, EEncodinType type, IEncryptConfig config);
	}
}