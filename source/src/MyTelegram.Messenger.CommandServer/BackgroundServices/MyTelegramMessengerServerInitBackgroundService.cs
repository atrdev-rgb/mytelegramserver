﻿using EventFlow.Core;
using Microsoft.Extensions.Hosting;
using MyTelegram.Messenger.Services.Filters;
using ReadHistoryStartedSagaEvent = MyTelegram.Domain.Sagas.ReadHistoryStartedSagaEvent;

namespace MyTelegram.Messenger.CommandServer.BackgroundServices;

public class MyTelegramMessengerServerInitBackgroundService(
    IServiceProvider serviceProvider,
    ILogger<MyTelegramMessengerServerInitBackgroundService> logger,
    IHandlerHelper handlerHelper,
    IDataSeeder dataSeeder,
    IIdGenerator idGenerator,
    IJsonSerializer jsonSerializer,
    IOptions<MyTelegramMessengerServerOptions> options,
    IMongoDbIndexesCreator mongoDbIndexesCreator)
    : BackgroundService
{
    private readonly IIdGenerator _idGenerator = idGenerator;
    private readonly MyTelegramMessengerServerOptions _options = options.Value;

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        logger.LogInformation("Command server starting...");
        handlerHelper.InitAllHandlers(typeof(MyTelegramMessengerServerExtensions).Assembly);
        //IdGeneratorFactory.SetDefaultIdGenerator(_idGenerator);
        await mongoDbIndexesCreator.CreateAllIndexesAsync();
        if (_options.UseInMemoryFilters)
        {
            await serviceProvider.GetRequiredService<IInMemoryFilterDataLoader>().LoadAllFilterDataAsync()
         ;
        }
        await dataSeeder.SeedAsync();
        logger.LogInformation("Command server started");
    }
}
