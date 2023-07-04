double GetRand(){
    Random rand = new Random();
    double number = rand.NextDouble() * rand.Next(1,11);
    number = Math.Round(number, 2);
    return number;
}

double [,] GetArray(int [] array){
    Random rand = new Random();
    double number = rand.NextDouble() * rand.Next(1,11);
    double [,] arrayNew = new double [array[0], array[1]];
    for(int i = 0; i < array[0]; i++){
        for(int j = 0; j < array[1]; j++){
            arrayNew[i, j] = GetRand();
        }
    }
    return arrayNew;
}

void PrintArray(double [,] array){
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    for (int i = 0; i < row; i++){
        for (int j = 0; j < col; j++){
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int [] GetArrayDiap(){
    int [] array = new int [2];
    Console.Write("Введите два числа от одного до пяти: ");
    int num1 = Convert.ToInt32(Console.ReadLine()); 
    array[0] = num1;
    int num2 = Convert.ToInt32(Console.ReadLine());
    array[1] = num2;
    return array;
}

int [] diap = GetArrayDiap();
double [,] array = GetArray(diap);
PrintArray(array);