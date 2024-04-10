
using InterpreterPattern;

Console.WriteLine("Interpreter design pattern!");
string markup = @"
                    # This is a header
                    This is a regular paragraph.
                    *This is a bold text.*
                    _This is an italic text._";

MarkupInterpreter markupInterpreter = new MarkupInterpreter();

string html = markupInterpreter.Interpret(markup);

Console.WriteLine(html);


Console.ReadKey();
