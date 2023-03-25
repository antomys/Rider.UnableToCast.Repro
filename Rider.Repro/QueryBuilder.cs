namespace Rider.Repro;

internal ref struct QueryBuilder
{
	private QueryStruct _query;

	public QueryBuilder(int queryParamsAmount)
	{
		_query = new QueryStruct(queryParamsAmount);
	}

	public static QueryBuilder Create(int queryParamsAmount)
	{
		return new QueryBuilder(queryParamsAmount);
	}

	public QueryBuilder AddArray(string[] array, string queryParamName)
	{
		if (array.Length is 0)
		{
			return this;
		}

		var queryParam = KeyValuePair.Create(
			Uri.EscapeDataString(queryParamName),
			Uri.EscapeDataString(string.Join(';', array)));

		_query.AddKey(queryParam);

		return this;
	}

	public QueryStruct Build()
	{
		return _query;
	}
}
