using System;
using System.Runtime.InteropServices;

namespace TreeSitter.V
{
    public class VLanguage
    {
        private const string DllName = "tree-sitter-v";

        [DllImport(DllName)]
        private static extern IntPtr tree_sitter_v();

        public static Language Create() => new Language(tree_sitter_v());
    }
}
