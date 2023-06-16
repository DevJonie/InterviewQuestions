using System.Text;

var strExp = "(3 + 3)   * (2 -2 ) ";
Console.WriteLine($"{strExp} = {Evaluate(strExp)}");


double Evaluate(string expression)
{
    var ops = new Stack<char>();
    var values = new Stack<double>();

    var tokens = expression.ToCharArray();

    for (int i = 0; i < tokens.Length; i++)
    {
        if (tokens[i].IsNumber())
        {
            var sb = new StringBuilder();
            sb.Append(tokens[i]);
            while (i + 1 < tokens.Length && tokens[i + 1].IsNumber())
            {
                sb.Append(tokens[++i]);
            }
            values.Push(double.Parse(sb.ToString()));
        }
        else if (tokens[i] == '(')
        {
            ops.Push(tokens[i]);
        }
        else if (tokens[i] == ')')
        {
            values.Push(ops.Pop().ApplyOp(values.Pop(), values.Pop()));
            ops.Pop();
        }
        else if (tokens[i].IsMathOp())
        {
            while (ops.Count > 0 && ops.Peek().HasPrecedence(tokens[i]))
            {
                values.Push(ops.Pop().ApplyOp(values.Pop(), values.Pop()));
            }
            ops.Push(tokens[i]);
        }
    }

    while (ops.Count > 0)
    {
        values.Push(ops.Pop().ApplyOp(values.Pop(), values.Pop()));
    }

    return values.Pop();
}


public static class OpsExtensions
{
    public static double ApplyOp(this char op, double b, double a)
    {
        return op switch
        {
            '+' => a + b,
            '-' => a - b,
            '*' => a * b,
            '/' => a / b,
            _ => throw new ArgumentException($"Invalid operator: {op}"),
        };
    }

    public static bool HasPrecedence(this char op2, char op1)
    {
        if (op2 == '(' || op2 == ')')
        {
            return false;
        }

        if ((op1 == '*' || op1 == '/') && (op2 == '+' || op2 == '-'))
        {
            return false;
        }

        return true;
    }

    public static bool IsMathOp(this char op)
    {
        return op == '+' || op == '-' || op == '*' || op == '/';
    }
    
    public static bool IsNumber(this char token)
    {
        return char.IsNumber(token);
    }

}