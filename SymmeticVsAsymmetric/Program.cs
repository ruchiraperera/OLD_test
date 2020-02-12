using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymmeticVsAsymmetric
{
    class Program
    {
        static void Main(string[] args)
        {

            //// sysmmetic encryption
            ///  encrution with key and server side has the same key to decrypt it
            ///  but the issue is sending key to server side and store in the phycically
            ///  

            ////
            /// thats why its introduce asymmentric encryption
            /// in there - both parties have public key and private key
            /// for encryption mechanisum they share public key between them.
            /// so first party will encrypt data using public key of second person
            /// so when second party receives encryption data, he can use his private key to encryt data usinf private key
            /// so same for second party encryption
            ////
            ///
        }
    }
}
