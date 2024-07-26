using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;

namespace CashFlow.Application.UseCases.Expenses.Register;
public interface IGetAllExpenseUseCase
{
    Task<ResponseExpensesJson> Execute();
}
