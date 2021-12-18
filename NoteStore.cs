using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Solution
{
    public class NotesStore
    {


        Dictionary<string, string> notes = new Dictionary<string, string>();
        public NotesStore() { }
        public void AddNote(String state, String name)
        {
            if (name == String.Empty)
            {
                throw new Exception("Name cannot be empty");
            }
            if (state.ToLower() != "completed" && state.ToLower() != "active" && state.ToLower() != "others")
            {
                throw new Exception($"Invalid state {state}");
            }
            notes.Add(name, state);

        }
        public List<String> GetNotes(String state)
        {
            if (state.ToLower() != "completed" && state.ToLower() != "active" && state.ToLower() != "others")
            {
                throw new Exception($"Invalid state {state}");
            }
            return notes.Where(x => x.Value.ToLower() == state.ToLower()).Select(x => x.Key).ToList();
        }
    }
}