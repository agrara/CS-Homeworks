using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Articles
{
    internal class Article
    {
        private string title;
        private string content;
        private string author;

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article() { }
        
        public Article(string title, string content, string author) {

            this.title = title;
            this.content = content;
            this.author = author;

        }

        public Article(string[] dataString) {

            this.title = dataString[0];
            this.content = dataString[1];
            this.author = dataString[2];

        }

        public void EditContent(string newContent) {
            
            this.content = newContent;

        }

        public void changeAuthor(string newAuthor) { 
        
            this.author = newAuthor;
            
        }

        public void rename(string newTitle) { 
        
            this.title = newTitle;
        
        }

        public override string ToString() {

            return $"{this.title} - {this.content}: {this.author}\n";

        }

    }
}
