/**
 * Дана последовательность из N целых чисел и число K. 
 * Необходимо сдвинуть всю последовательность (сдвиг - циклический) на |K| элементов вправо, 
 * если K – положительное и влево, если отрицательное. 
 * 
 * (1 ≤ N ≤ 105, |K| ≤ 105, |Ai| ≤ 100).
 * 
 * Сдвиг будем делать в "новый массив".
 * Структуру и значения переменных в исходном файле считаем корректными, проверку не производим.
 * 
 */


using System.IO;


// Файлы для ввода-вывода
const string fileInput = "input.txt";
const string fileOutput = "Output.txt";

// исходный массив 
string[] startArray = { };
// формируемый массив
string[] newArray;

int K = 0;

// чтениеи данных
StreamReader fileRead = new StreamReader(fileInput);
int N = Convert.ToInt32(fileRead.ReadLine());

string line = fileRead.ReadLine();

K = Convert.ToInt32(fileRead.ReadLine());
startArray = line.Split(' ', N);

fileRead.Close();

// обработка

newArray = new string[startArray.Length];

K = (K > 0) ? (K - 1) : N + (K + 1);

int cntCopy = 0;
while (cntCopy < newArray.Length)
{
    newArray[cntCopy] = startArray[K];
    cntCopy++;
    K++;
    if (K == newArray.Length)
        K = 0;
}

// сохранение

line = String.Join(' ', newArray);

Console.WriteLine(line);

StreamWriter fileWrite = new StreamWriter(fileOutput, false);

fileWrite.WriteLine(line);

fileWrite.Close();


