﻿namespace Redbean.Api
{
	public static class SecurityExtension
	{
		private static readonly AES128 AES128 = new();
		public static string Encrypt(this string value) => AES128.Encrypt(value);
		public static string Decrypt(this string value) => AES128.Decrypt(value);
	}
}