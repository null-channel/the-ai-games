
console.log('The AIs are here');

function findSum2020ExpenseReport(expenseReport) {
	for (let i = 1; i < expenseReport.length - 1; ++i)
		if ((expenseReport[i] + expenseReport[i+1]) === 2020){
			return [expenseReport[i], expenseReport[i+1]]}

	throw new Error("No pair found")
};