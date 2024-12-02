using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class TextEditor
    {
        private string? _text;
        private readonly List<ICommand> _history = new();

        public void InsertText(string text)
        {
            _text += text;
        }

        public void DeleteText(int length)
        {
            if (length > _text.Length)
            {
                length = _text.Length;
            }
            _text = _text.Substring(0, _text.Length - length);
        }

        public void Execute(ICommand command)
        {
            command.Execute();
            _history.Add(command);
        }
        public void Undo()
        {
            if (_history.Count == 0) return;
            var lastCommand = _history[_history.Count - 1];
            _history.RemoveAt(_history.Count - 1);
            lastCommand.Undo();
        }
        public string GetText()
        {
            return _text;
        }
    }
}
