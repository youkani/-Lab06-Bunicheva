//задание 1.1
// for (int i = 10; i >=1; i--) {
//     Console.WriteLine(i);
// }

// задание 1.2
// for (int i = 1; i<= 50; i++) {
//     if (i%2 != 0) continue;
//     Console.WriteLine(i);
// }

//задание 2
// int sum = 0;
// int count = 0;
// for (int i = 1; i <= 100; i++) {
//     if (i%3 == 0) {
//         sum += i;
//     };
//     if (i%7 == 0) {
//         count++;
//     };
// }
// Console.WriteLine($"сумма чисел, кратных 3: {sum}");
// Console.WriteLine($"количество чисел, кратных 7: {count}");

//задание 3
// Console.Write("Напишите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int pologit = 0;
// int otritsat = 0;
// while (number != 0) {
//     if (number > 0) {
//         pologit++;
//     }
//     if (number < 0) {
//         otritsat++;
//     }
//     Console.Write("Напишите число: ");
//     number = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine($"Количество положительных чисел: {pologit}");
// Console.WriteLine($"Количество отрицательных чисел: {otritsat}");

//задание 4
// string password;
// bool ygadan = false;
// for (int i = 1; i<=3;i++){
//     Console.Write("Введите пароль: ");
//     password = Console.ReadLine();

//    if (password == "qwerty"){
// Console.WriteLine("Доступ разрешён");
//     ygadan = true;
//         break;
//     };
// }
// if (ygadan == false){
//     Console.WriteLine("Доступ заблокирован");
//     };

//задание 5
// int n = 0;
// Console.Write("Введите число от 1 до 9: ");
// n = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i<=10; i++){
//     Console.WriteLine($"{n} * {i} = {n*i}");
// }

//задание 6
for (int i = 1; i <= 30; i++) {
    if (i % 3 == 0) {
        continue;
    }
    if (i % 10) & (i > 20) {
        break;
    }
}