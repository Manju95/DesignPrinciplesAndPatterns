using System;
using System.Text;
using DotnetTraining.DesignPrinciples.SOLID.Interfaces;

namespace DotnetTraining.SOLID
{
	public class LSPExample
	{

        public void RunLSP()
        {
            SqlFileManager fileManager = new SqlFileManager();
            //fileManager.SaveTextToFiles();
            //fileManager.GetTextFromFiles();
        }
	}

    // voilets LSP
    //public class SqlFile
    //{
    //	public string FilePath { get; set; }
    //	public string FileText { get; set; }

    //	public string LoadText()
    //	{
    //		return FileText;
    //	}

    //	public void SaveText()
    //	{
    //		// Code to save text in sql file
    //	}
    //}

    // voilets LSP
    //public class SqlFileManager
    //{
    //	public List<SqlFile> SqlFiles { get; set; }

    //	public string GetTextFromFiles()
    //	{
    //		StringBuilder sb = new StringBuilder();
    //		foreach (var file in SqlFiles)
    //		{
    //			sb.Append(file.LoadText());
    //		}

    //		return sb.ToString();
    //	}

    //	public void SaveTextToFiles()
    //	{
    //		foreach (var file in SqlFiles)
    //		{
    //			file.SaveText();
    //		}
    //	}
    //}

    public class SqlFile : IWrittableSqlFile, IReadableSqlFile
    {
        public string FilePath { get; set; }
        public string FileText { get; set; }

        public string LoadText()
        {
            return FileText;
        }

        public void SaveText()
        {
            // Code to save text in sql file
        }
    }

    public class SqlFileManager
    {
        public List<SqlFile> SqlFiles { get; set; }

        public string GetTextFromFiles(List<IReadableSqlFile> files)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var file in files)
            {
                sb.Append(file.LoadText());
            }

            return sb.ToString();
        }

        public void SaveTextToFiles(List<IWrittableSqlFile> files)
        {
            foreach (var file in files)
            {
                file.SaveText(); 
            }
        }
    }
}