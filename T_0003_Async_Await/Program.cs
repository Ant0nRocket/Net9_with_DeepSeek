async Task<string> DownloadDataAsync(string url)
{
  Console.WriteLine("Начало загрузки. Поток: " + Thread.CurrentThread.ManagedThreadId);
  using HttpClient client = new HttpClient();

  // Вызываем в другом потоке что-то полезное
  string data = await client.GetStringAsync(url);

  // Этот код не исполнится, пока не завершится загрузка
  Console.WriteLine("Загрузка завершена. Поток: " + Thread.CurrentThread.ManagedThreadId);

  // вернётся таска со стрингом в клювике, её нужно будет await'ить
  return data.ToUpper();
}

string url = "https://google.com";
await DownloadDataAsync(url);