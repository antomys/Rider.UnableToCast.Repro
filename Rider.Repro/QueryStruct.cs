namespace Rider.Repro;

public ref struct QueryStruct
{
	private readonly Span<KeyValuePair<string, string>> _keys;
	private int _keysLastIndex;
	
	public QueryStruct(int length)
	{
		_keys = new KeyValuePair<string, string>[length];
		_keysLastIndex = 0;
	}

	public void AddKey(KeyValuePair<string, string> pair)
	{
		_keys[_keysLastIndex++] = pair;
	}
}
