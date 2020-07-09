using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Helpfull
{
    /// <summary>
    /// It calculate text/files to hash. It use some popular methods of algorithm. Hash is a way, to encrypt something. For example passwords, to save it in the Database.
    /// </summary>
    public class Hash
    {
        /// <summary>Calculate/Convert text to an MD5-Hash.</summary>
        /// <param name="text">The text, witch will be converted to a MD5-hash.</param>
        /// <returns>The calculated MD5-Hash</returns>
        /// <example>
        /// <code>
        /// string Hash = Helpfull.Hash.CalculateMD5(Text);
        /// </code>
        /// </example>
        public static string CalculateMD5(string text)
        {
            byte[] TextBytes = Encoding.ASCII.GetBytes(text);

            using (var md5 = MD5.Create())
            {
                var hash = md5.ComputeHash(TextBytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
            }
        }


        /// <summary>Calculate/Convert a file to an MD5-Hash.</summary>
        /// <param name="text">The filename of the file, witch will be converted in a MD5-hash</param>
        /// <returns>The calculated MD5-Hash of the File</returns>
        /// <example>
        /// <code>
        /// string Hash = Helpfull.Hash.CalculateMD5File(Filename);
        /// </code>
        /// </example>
        public static string CalculateMD5File(string file)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(file))
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }


        /// <summary>Calculate/Convert text to an SHA1-Hash. But attention: SHA1 is an old used algorithm. It's easy to crack.</summary>
        /// <param name="text">The text, witch will be converted to a SHA1-hash.</param>
        /// <returns>The calculated SHA1-Hash</returns>
        /// <example>
        /// <code>
        /// string Hash = Helpfull.Hash.CalculateSHA1(Text);
        /// </code>
        /// </example>
        public static string CalculateSHA1(string text)
        {
            byte[] TextBytes = Encoding.ASCII.GetBytes(text);

            using (var sha1 = SHA1.Create())
            {
                var hash = sha1.ComputeHash(TextBytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
            }
        }


        /// <summary>Calculate/Convert a file to an SHA1-Hash. But attention: SHA1 is an old used algorithm. It's easy to crack.</summary>
        /// <param name="text">The filename of the file, witch will be converted in a SHA1-hash</param>
        /// <returns>The calculated SHA1-Hash of the File</returns>
        /// <example>
        /// <code>
        /// string Hash = Helpfull.Hash.CalculateSHA1File(Filename);
        /// </code>
        /// </example>
        public static string CalculateSHA1File(string file)
        {
            using (var sha1 = SHA1.Create())
            {
                using (var stream = File.OpenRead(file))
                {
                    var hash = sha1.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }


        /// <summary>Calculate/Convert text to an SHA256-Hash.</summary>
        /// <param name="text">The text, witch will be converted to a SHA256-hash.</param>
        /// <returns>The calculated SHA256-Hash</returns>
        /// <example>
        /// <code>
        /// string Hash = Helpfull.Hash.CalculateSHA256(Text);
        /// </code>
        /// </example>
        public static string CalculateSHA256(string text)
        {
            byte[] TextBytes = Encoding.ASCII.GetBytes(text);

            using (var sha256 = SHA256.Create())
            {
                var hash = sha256.ComputeHash(TextBytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
            }
        }


        /// <summary>Calculate/Convert a file to an SHA256-Hash.</summary>
        /// <param name="text">The filename of the file, witch will be converted in a SHA256-hash</param>
        /// <returns>The calculated SHA256-Hash of the File</returns>
        /// <example>
        /// <code>
        /// string Hash = Helpfull.Hash.CalculateSHA256File(Filename);
        /// </code>
        /// </example>
        public static string CalculateSHA256File(string file)
        {
            using (var sha256 = SHA256.Create())
            {
                using (var stream = File.OpenRead(file))
                {
                    var hash = sha256.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }


        /// <summary>Calculate/Convert text to an SHA384-Hash</summary>
        /// <param name="text">The text, witch will be converted to a SHA384-hash.</param>
        /// <returns>The calculated SHA384-Hash</returns>
        /// <example>
        /// <code>
        /// string Hash = Helpfull.Hash.CalculateSHA384(Text);
        /// </code>
        /// </example>
        public static string CalculateSHA384(string text)
        {
            byte[] TextBytes = Encoding.ASCII.GetBytes(text);

            using (var sha384 = SHA384.Create())
            {
                var hash = sha384.ComputeHash(TextBytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
            }
        }


        /// <summary>Calculate/Convert a file to an SHA384-Hash.</summary>
        /// <param name="text">The filename of the file, witch will be converted in a SHA384-hash</param>
        /// <returns>The calculated SHA384-Hash of the File</returns>
        /// <example>
        /// <code>
        /// string Hash = Helpfull.Hash.CalculateSHA384File(Filename);
        /// </code>
        /// </example>
        public static string CalculateSHA384File(string file)
        {
            using (var sha384 = SHA384.Create())
            {
                using (var stream = File.OpenRead(file))
                {
                    var hash = sha384.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }


        /// <summary>Calculate/Convert text to an SHA512-Hash</summary>
        /// <param name="text">The text, witch will be converted to a SHA512-hash.</param>
        /// <returns>The calculated SHA512-Hash</returns>
        /// <example>
        /// <code>
        /// string Hash = Helpfull.Hash.CalculateSHA512(Text);
        /// </code>
        /// </example>
        public static string CalculateSHA512(string text)
        {
            byte[] TextBytes = Encoding.ASCII.GetBytes(text);

            using (var sha512 = SHA512.Create())
            {
                var hash = sha512.ComputeHash(TextBytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
            }
        }

        /// <summary>Calculate/Convert a file to an SHA512-Hash.</summary>
        /// <param name="text">The filename of the file, witch will be converted in a SHA512-hash</param>
        /// <returns>The calculated SHA512-Hash of the File</returns>
        /// <example>
        /// <code>
        /// string Hash = Helpfull.Hash.CalculateSHA512File(Filename);
        /// </code>
        /// </example>
        public static string CalculateSHA512File(string file)
        {
            using (var sha512 = SHA512.Create())
            {
                using (var stream = File.OpenRead(file))
                {
                    var hash = sha512.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }
    }
}