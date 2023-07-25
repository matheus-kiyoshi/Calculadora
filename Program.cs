static string Calc(string Num, double Value1, double Value2)
{
    switch (Num)
    {
        case "1":
            try
            {
                double Resultado = Value1 + Value2;
                return Resultado.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERRO: {ex.Message}");
                return "Inválido";
            }
        case "2":
            try
            {
                double Resultado = Value1 - Value2;
                return Resultado.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERRO: {ex.Message}");
                return "Inválido";
            }
        case "3":
            try
            {
                double Resultado = Value1 * Value2;
                return Resultado.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERRO: {ex.Message}");
                return "Inválido";
            }
        case "4":
            try
            {
                if (Value2 == 0)
                {
                    return "Divisão por zero não é permitida.";
                }
                else
                {
                    double Resultado = Value1 / Value2;
                    return Resultado.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERRO: {ex.Message}");
                return "Inválido";
            }
        case "5":
            try
            {
                double Resultado = Value1 % Value2;
                return Resultado.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERRO: {ex.Message}");
                return "Inválido";
            }
        default:
            return "Inválido";
    }
}

static double ValueVerify()
{
    double Value;
    double Val;
    string V = Console.ReadLine();
        
    try
    {
        Val = double.Parse(V);
    }
    catch
    {
        Console.WriteLine("O valor é inválido, tente novamente;");
        return 1242145515;
    }

    Value = double.Parse(V);
    return Value;
}

string Resp;
string Response;

do
{
    Console.WriteLine("Qual a operação desejada?");

    Console.WriteLine();

    Console.WriteLine("[1] - Adição");
    Console.WriteLine("[2] - Subtração");
    Console.WriteLine("[3] - Multiplicação");
    Console.WriteLine("[4] - Divisão");
    Console.WriteLine("[5] - Módulo/Resto");

    string Num;
    do
    {
        Num = Console.ReadLine();
        if (Num != "1" && Num != "2" && Num != "3" && Num != "4" && Num != "5")
        {
            Console.WriteLine("Digite uma opção válida!");
        }
    } while (Num != "1" && Num != "2" && Num != "3" && Num != "4" && Num != "5");

    Console.Clear();

    Console.WriteLine("Digite um valor: ");
    double Value1;
    do
    {
        Value1 = ValueVerify();
    } while (Value1 == 1242145515);

    Console.WriteLine();

    Console.WriteLine("Digite outro valor: ");
    double Value2;
    do
    {
        Value2 = ValueVerify();
    } while (Value2 == 1242145515);
     
    Console.Clear();

    string Resultado = Calc(Num, Value1, Value2);

    Console.WriteLine($"Resultado: {Resultado}");

    Console.WriteLine();

    Console.WriteLine("Deseja Continuar?");
    Response = Console.ReadLine();
    Resp = Response.ToUpper();

} while (Resp == "S" || Resp == "SIM" || Resp == "Y" || Resp == "Yes");