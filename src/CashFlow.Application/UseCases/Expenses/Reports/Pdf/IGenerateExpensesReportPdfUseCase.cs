namespace CashFlow.Application.UseCases.Expenses.Reports.Excel;
public interface IGenerateExpensesReportPdfUseCase
{
    Task<byte[]> Execute(DateOnly month);
}
