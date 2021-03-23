using System;
using System.Reflection;

namespace Chapter23 {
    public class SearchEngine {
        public virtual string[] search(string item) {
            return new string[0];
        }
    }

    public class GoogleSearch : SearchEngine {
        public override string[] search(string item) {
            return new string[] {
                "Here are some results: ",
                "Aren't they neat?",
                "I found 1.2 results. Returning the first three."
            };
        }

    }

    public class UlySearch : SearchEngine {
        public string[] information { get; set; }

        public override string[] search(string item) {
            information = new string[] {
                "Here's you old string: ",
                "Now good day to you."
            };

            string[] temp = new string[information.Length];
            for (int i = 0; i < temp.Length; i++) {
                temp[i] = information[i];
            }

            return temp;
        }
    }
    
    class Program {
        static void Main(string[] args) {
            GoogleSearch search1 = new GoogleSearch();
            UlySearch search2 = new UlySearch();
            Console.WriteLine($"Search Results (Google) : {search1.search("hello").ToString()}");
            Console.WriteLine($"Search Results (Ulys) : {search2.search("hello")[1]}");
        }
    }
}