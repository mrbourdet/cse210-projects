using System;
public class Journal
    {
        public Entry _journalEntry = new Entry();
        public List<Entry> _entries = new List<Entry>();
        public void WriteJournal()
        {
            DateTime currentDateTime = DateTime.Now;;
            _journalEntry._dateEntry = currentDateTime.ToString("dd/MM/yyyy");
            _journalEntry._promptEntry = Prompt.RandomPrompt();
            Console.WriteLine($"{_journalEntry._promptEntry} ");
            _journalEntry._userEntry = Console.ReadLine();
            //Console.WriteLine($"{journalEntry._dateEntry}, {journalEntry._promptEntry}, {journalEntry._userEntry}");
            _entries.Add(_journalEntry);
            _journalEntry = new Entry();  
        }  
        public void DisplayJournal()
        {
            foreach (Entry entry in _entries)
            {
                Console.WriteLine($"{entry._dateEntry}, {entry._promptEntry}, {entry._userEntry}");
            };
        }
        public void LoadJournal()
        {
            string line;
            _entries.Clear();
            //https://stackoverflow.com/questions/9763796/reading-from-a-text-file-and-splitting-each-individual-line-into-different-arra
            using(StreamReader readText = new StreamReader("write.csv"))
            {
                string[] cleanLine;
                //Read the first line of text
                while (readText.Peek() >= 0)
                {
                    line = readText.ReadLine();
                    cleanLine = line.Split(",");
                    _journalEntry._dateEntry = cleanLine[0];
                    _journalEntry._promptEntry = cleanLine[1];
                    _journalEntry._userEntry = cleanLine[2];
                    _entries.Add(_journalEntry);
                    _journalEntry = new Entry();
                }
            }
        }
        public void SaveJournal()
        {
            using(StreamWriter writetext = new StreamWriter("write.csv"))
            {
                foreach (Entry entry in _entries)
                {
                    writetext.WriteLine($"{entry._dateEntry},{entry._promptEntry},{entry._userEntry}");
                };
            } 
        }
    }