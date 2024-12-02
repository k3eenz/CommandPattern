using CommandPattern;

TextEditor editor = new TextEditor();


var insert1 = new InsertTextCommand(editor, "Hello, ");
var insert2 = new InsertTextCommand(editor, "Hello");
var delete = new DeleteTextCommand(editor, 3);

editor.Execute(insert1);
Console.WriteLine(editor.GetText());

editor.Execute(insert2);
Console.WriteLine(editor.GetText());

editor.Execute(delete);
Console.WriteLine(editor.GetText());

editor.Undo();
Console.WriteLine(editor.GetText());

editor.Undo();
Console.WriteLine(editor.GetText());
