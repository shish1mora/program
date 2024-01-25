using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;


namespace Exam
{
    public class WordProcesser
    {
        private FileInfo _fileInfo;
        public WordProcesser(string filename) {
            if(File.Exists(filename))
            {
                _fileInfo = new FileInfo(filename);
            }
            else
            {
                throw new ArgumentException("Файл не найден");
            }
        }

        internal bool Process(Dictionary<string, string> dictionary)
        {
            Word.Application app = null;
            try
            {
   