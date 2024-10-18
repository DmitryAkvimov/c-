Workbook workbook = new Workbook("output.xlsx");
Worksheet worksheet = workbook.Worksheets[0];

var pivotTable = worksheet.PivotTables[0];
var dataBodyRange = pivotTable.DataBodyRange;
int currentRow = 1;
int rowsUsed = dataBodyRange.EndRow;

// Сортировка значений по убыванию
PivotField field = pivotTable.RowFields[0];
field.IsAutoSort = true;
field.IsAscendSort = false;
field.AutoSortField = 0;

pivotTable.RefreshData();
pivotTable.CalculateData();

// Скрытие строк со значением меньше 15
while (currentRow < rowsUsed)
{
	Cell cell = worksheet.Cells[currentRow, 2];
	double score = Convert.ToDouble(cell.Value);
	if (score < 15)
	{
		worksheet.Cells.HideRow(currentRow);
	}
	currentRow++;
}

pivotTable.RefreshData();
pivotTable.CalculateData();

// Сохранение файла Excel
workbook.Save("PivotTableHideAndSort.xlsx");
