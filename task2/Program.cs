int [] GetArrayDiap(){
    int [] array = new int [2];
    Random rand = new Random();
    int num1 = rand.Next(2, 5);
    int num2 = rand.Next(2, 6);
    array[0] = num1;
    array[1] = num2;
    return array;
}
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

int [] TakeStand(){
    int [] array = new int [2];
    Console.WriteLine("Введите координаты для двумерного от одного до пяти:");
    int row = Convert.ToInt32(Console.ReadLine()) - 1;
    int col = Convert.ToInt32(Console.ReadLine()) - 1;
    array[0] = row;
    array[1] = col;
    return array;
}

bool GetPosition(double [,] array, int [] coordinate){
    bool coordinateAnswer = false;
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            if(i == coordinate[0] && j == coordinate[1]){
            coordinateAnswer = true;
            break;
            }   
        }
    }
    return coordinateAnswer;
}

void ReturnAnswer(bool answer, double[,] array, int [] coordinate){
    PrintArray(array);
    if(answer == true){
        Console.WriteLine($"Элемент с веддеными коордтнатами для массива = {array[coordinate[0], coordinate[1]]}");
    }
    else Console.WriteLine("Эллемент не найден");

}

int [] diap = GetArrayDiap();
double [,] array = GetArray(diap);
Console.WriteLine();
int [] position = TakeStand();
bool answer = GetPosition(array, position);
ReturnAnswer(answer, array, position);
