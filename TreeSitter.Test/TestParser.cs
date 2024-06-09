using NUnit.Framework;
using TreeSitter.V;

using Regex = System.Text.RegularExpressions.Regex;

namespace TreeSitter.Test
{
    public class TestParser
    {
        [Test]
        public void TestSetLanguage()
        {
            var parser = new Parser
            {
                Language = VLanguage.Create()
            };

            var tree = parser.Parse("pub fn main() \n{\n}");
            Assert.AreEqual(Trim(@"(source_file (function_declaration (visibility_modifiers) name: (identifier) signature: (signature parameters: (parameter_list))) (block))"), tree.Root.ToString());
        }

        private static string Trim(string a)
        {
            return Regex.Replace(a, @"\s+", " ");
        }
    }
}