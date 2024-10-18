/*
using System;
using System.IO;
using OfficeOpenXml;

class Program
{
    static void Main()
    {
        // Инициализируем начальные значения
        double totalIncome = 0;
        double firmABusiness = 0;
        double firmAPersonal = 0;
        double firmBBusiness = 0;
        double firmBPersonal = 0;

        // Вводим суммы поступления фирмы А и фирмы Б
        Console.Write("Введите сумму поступления фирмы А: ");
        double incomeA = double.Parse(Console.ReadLine());
        Console.Write("Введите сумму поступления фирмы Б: ");
        double incomeB = double.Parse(Console.ReadLine());

        // Вычисляем общий доход
        totalIncome = (incomeA + incomeB) * 0.035;

        // Вводим суммы для фирмы А
        Console.Write("Введите сумму для счета а1(бизнес) фирмы А: ");
        firmABusiness = double.Parse(Console.ReadLine());
        Console.Write("Введите сумму для счета а2(физ) фирмы А: ");
        firmAPersonal = double.Parse(Console.ReadLine());

        // Вычисляем остаток для фирмы А
        double remainingA = incomeA - (firmABusiness + firmAPersonal);

        // Вводим суммы для фирмы Б
        Console.Write("Введите сумму для счета б1(бизнес) фирмы Б: ");
        firmBBusiness = double.Parse(Console.ReadLine());
        Console.Write("Введите сумму для счета б2(физ) фирмы Б: ");
        firmBPersonal = double.Parse(Console.ReadLine());

        // Вычисляем остаток для фирмы Б
        double remainingB = incomeB - (firmBBusiness + firmBPersonal);

        // Создаем новую папку для файла Excel
        string folderPath = "ExcelReports";
        Directory.CreateDirectory(folderPath);

        // Устанавливаем имя файла Excel
        string excelFileName = Path.Combine(folderPath, "Report.xlsx");

        // Создаем новый файл Excel и добавляем в него данные
        using (var package = new ExcelPackage(new FileInfo(excelFileName)))
        {
            var worksheet = package.Workbook.Worksheets.Add("Report");

            // Заполняем данные в Excel
            worksheet.Cells["A1"].Value = "Общий средний доход";
            worksheet.Cells["B1"].Value = totalIncome;

            worksheet.Cells["A2"].Value = "Остаток для фирмы А";
            worksheet.Cells["B2"].Value = remainingA;

            worksheet.Cells["A3"].Value = "Остаток для фирмы Б";
            worksheet.Cells["B3"].Value = remainingB;

            // Сохраняем файл Excel
            package.Save();
        }

        Console.WriteLine("Данные сохранены в файле: " + excelFileName);
    }
}


using System;
using System.IO;
using OfficeOpenXml;

class Program
{
    static void Main()
    {
        // Инициализируем начальные значения
        string companyName = "";
        double totalIncome = 0;
        double firmABusiness = 0;
        double firmAPersonal = 0;
        double firmBBusiness = 0;
        double firmBPersonal = 0;

        // Вводим имя компании
        Console.Write("Введите имя компании: ");
        companyName1 = Console.ReadLine();

        // Вводим суммы поступления фирмы А и фирмы Б
        Console.Write($"Введите сумму поступления фирмы {companyName}: ");
        double incomeA = double.Parse(Console.ReadLine());
        Console.Write($"Введите сумму поступления фирмы {companyName}: ");
        double incomeB = double.Parse(Console.ReadLine());

        // Вычисляем общий доход
        totalIncome = (incomeA + incomeB);

        // Вводим суммы для фирмы А
        Console.Write($"Введите сумму для счета а1(бизнес) фирмы {companyName}: ");
        firmABusiness = double.Parse(Console.ReadLine());
        Console.Write($"Введите сумму для счета а2(физ) фирмы {companyName}: ");
        firmAPersonal = double.Parse(Console.ReadLine());

        // Вводим имя компании
        Console.Write("Введите имя компании: ");
        companyName2 = Console.ReadLine();

        // Вводим суммы для фирмы Б
        Console.Write("Введите сумму для счета б1(бизнес) фирмы Б: ");
        firmBBusiness = double.Parse(Console.ReadLine());
        Console.Write("Введите сумму для счета б2(физ) фирмы Б: ");
        firmBPersonal = double.Parse(Console.ReadLine());

        // Создаем новую папку для файла Excel
        string folderPath = "ExcelReports";
        Directory.CreateDirectory(folderPath);

        // Устанавливаем имя файла Excel
        string excelFileName = Path.Combine(folderPath, "Report.xlsx");

        // Создаем новый файл Excel и добавляем в него данные
        using (var package = new ExcelPackage(new FileInfo(excelFileName)))
        {
            var worksheet = package.Workbook.Worksheets.Add("Report");

            // Заполняем данные в Excel
            worksheet.Cells["A1"].Value = "Имя компании";
            worksheet.Cells["A2"].Value = companyName;

            worksheet.Cells["A4"].Value = "Дата";
            worksheet.Cells["B4"].Value = "Банк";
            worksheet.Cells["C4"].Value = "Сумма прихода";
            worksheet.Cells["D4"].Value = "Доход";
            worksheet.Cells["E4"].Value = "Доход в % от общей суммы";

            // Добавляем данные для фирмы А
            worksheet.Cells["A5"].Value = DateTime.Now.ToString("yyyy-MM-dd");
            worksheet.Cells["B5"].Value = "Фирма А";
            worksheet.Cells["C5"].Value = incomeA;
            worksheet.Cells["D5"].Value = firmABusiness + firmAPersonal;
            worksheet.Cells["E5"].Formula = $"(D5/C5)*100";

            // Добавляем данные для фирмы Б
            worksheet.Cells["A6"].Value = DateTime.Now.ToString("yyyy-MM-dd");
            worksheet.Cells["B6"].Value = "Фирма Б";
            worksheet.Cells["C6"].Value = incomeB;
            worksheet.Cells["D6"].Value = firmBBusiness + firmBPersonal;
            worksheet.Cells["E6"].Formula = $"(D6/C6)*100";

            // Сохраняем файл Excel
            package.Save();
        }

        Console.WriteLine("Данные сохранены в файле: " + excelFileName);
    }
}

*/

using System;
using System.IO;
using OfficeOpenXml;

class Program
{
    static void Main()
    {
        bool writeNewOrganization = true;

        while (writeNewOrganization)
        {
            // Вводим имя организации
            Console.Write("Введите имя организации: ");
            string companyName = Console.ReadLine();

            // Создаем новую папку для файла Excel
            string folderPath = "ExcelReports";
            Directory.CreateDirectory(folderPath);

            // Устанавливаем имя файла Excel
            string excelFileName = Path.Combine(folderPath, "Report.xlsx");

            // Создаем новый файл Excel или открываем существующий
            FileInfo excelFile = new FileInfo(excelFileName);
            using (var package = new ExcelPackage(excelFile))
            {
                ExcelWorksheet worksheet;

                if (package.Workbook.Worksheets.Count == 0)
                {
                    // Если листов нет, создаем новый
                    worksheet = package.Workbook.Worksheets.Add("Report");
                    InitializeWorksheet(worksheet);
                }
                else
                {
                    // Если лист с именем "Report" уже существует, используем его
                    worksheet = package.Workbook.Worksheets["Report"];
                }

                // Заполняем данные в Excel
                int row = GetLastUsedRow(worksheet) + 1;
                FillDataForOrganization(worksheet, row);

                // Сохраняем файл Excel
                package.Save();
            }

            Console.WriteLine("Данные сохранены в файле: " + excelFileName);

            Console.Write("Записать новую организацию? (да/нет): ");
            string newOrgResponse = Console.ReadLine();
            if (newOrgResponse.ToLower() != "да")
                writeNewOrganization = false;
        }
    }

    static void InitializeWorksheet(ExcelWorksheet worksheet)
    {
        worksheet.Cells["A1"].Value = "Имя компании";
        worksheet.Cells["A2"].Value = "Дата";
        worksheet.Cells["B2"].Value = "Банк";
        worksheet.Cells["C2"].Value = "Сумма прихода";
        worksheet.Cells["D2"].Value = "Доход";
        worksheet.Cells["E2"].Value = "Доход в % от общей суммы";
    }

    static int GetLastUsedRow(ExcelWorksheet worksheet)
    {
        int row = 2;
        while (worksheet.Cells[row, 1].Value != null)
        {
            row++;
        }
        return row - 1;
    }

    static void FillDataForOrganization(ExcelWorksheet worksheet, int row)
    {
        DateTime currentDate = DateTime.Now;
        Console.Write("Введите дату (гггг-мм-дд): ");
        string date = Console.ReadLine();
        Console.Write("Введите банк: ");
        string bank = Console.ReadLine();
        Console.Write("Введите сумму прихода: ");
        double income = double.Parse(Console.ReadLine());
        Console.Write("Введите доход: ");
        double profit = double.Parse(Console.ReadLine());

        worksheet.Cells[row, 1].Value = date;
        worksheet.Cells[row, 2].Value = bank;
        worksheet.Cells[row, 3].Value = income;
        worksheet.Cells[row, 4].Value = profit;
        worksheet.Cells[row, 5].Formula = $"(D{row}/C{row})*100";
    }
}