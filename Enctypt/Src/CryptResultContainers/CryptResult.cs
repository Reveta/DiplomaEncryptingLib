using Enctypt.Interfaces;

namespace Enctypt.CryptResultContainers {
	public class CryptResult : ICryptResult {
		public string CryptData { get; set; }
		public string Key { get; set; }
	}
}