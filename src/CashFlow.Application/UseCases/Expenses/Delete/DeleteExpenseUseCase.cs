using CashFlow.Domain.Repositories;
using CashFlow.Domain.Repositories.Expenses;
using CashFlow.Exception;

namespace CashFlow.Application.UseCases.Expenses.Delete;

public class DeleteExpenseUseCase : IDeleteExpenseUseCase
{
    private readonly IExpensesWriteOnlyRepository _repository;
    private readonly IUnitOfWork _unityOfWork;

    public DeleteExpenseUseCase(
        IExpensesWriteOnlyRepository repository,
        IUnitOfWork unityOfWork)
    {
        _repository = repository;
        _unityOfWork = unityOfWork;
    }

    public async Task Execute(long id)
    {
        var result = await _repository.Delete(id);

        if (!result)
        {
            throw new DirectoryNotFoundException(ResourceErrorMessages.EXPENSE_NOT_FOUND);
        }

        await _unityOfWork.Commit();
    }
}
