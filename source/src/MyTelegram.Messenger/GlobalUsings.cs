﻿global using EventFlow;
global using EventFlow.Aggregates;
global using EventFlow.Aggregates.ExecutionResults;
global using EventFlow.Commands;
global using EventFlow.Core;
global using EventFlow.EventStores;
global using EventFlow.Extensions;
global using EventFlow.Queries;
global using EventFlow.Sagas;
global using EventFlow.Snapshots;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Logging;
global using Microsoft.Extensions.Options;
global using MyTelegram.Core;
global using MyTelegram.Domain;
global using MyTelegram.Domain.Aggregates.AppCode;
global using MyTelegram.Domain.Aggregates.Channel;
global using MyTelegram.Domain.Aggregates.Chat;
global using MyTelegram.Domain.Aggregates.Contact;
global using MyTelegram.Domain.Aggregates.Dialog;
global using MyTelegram.Domain.Aggregates.Messaging;
global using MyTelegram.Domain.Aggregates.PeerNotifySettings;
global using MyTelegram.Domain.Aggregates.PeerSettings;
global using MyTelegram.Domain.Aggregates.Pts;
global using MyTelegram.Domain.Aggregates.Poll;
global using MyTelegram.Domain.Aggregates.PushDevice;
global using MyTelegram.Domain.Aggregates.QrCode;
global using MyTelegram.Domain.Aggregates.User;
global using MyTelegram.Domain.Aggregates.UserName;
global using MyTelegram.Domain.Aggregates.Temp;
global using MyTelegram.Domain.Commands.AppCode;
global using MyTelegram.Domain.Commands.Channel;
global using MyTelegram.Domain.Commands.Chat;
global using MyTelegram.Domain.Commands.Contact;
global using MyTelegram.Domain.Commands.Dialog;
global using MyTelegram.Domain.Commands.Messaging;
global using MyTelegram.Domain.Commands.Poll;
global using MyTelegram.Domain.Commands.PushDevice;
global using MyTelegram.Domain.Commands.QrCode;
global using MyTelegram.Domain.Commands.User;
global using MyTelegram.Domain.Commands.UserName;
global using MyTelegram.Domain.Commands.Temp;
global using MyTelegram.Domain.Events.Channel;
global using MyTelegram.Domain.Events.Chat;
global using MyTelegram.Domain.Events.Contact;
global using MyTelegram.Domain.Events.User;
global using MyTelegram.Domain.Events.Temp;
global using MyTelegram.Domain.Extensions;
global using MyTelegram.Domain.Sagas;
global using MyTelegram.Domain.Sagas.Events;
global using MyTelegram.Domain.Sagas.Identities;
global using MyTelegram.Domain.ValueObjects;
global using MyTelegram.EventBus;
global using MyTelegram.EventFlow.MongoDB;
global using MyTelegram.GrpcService;
global using MyTelegram.Messenger;
global using MyTelegram.Messenger.Extensions;
global using MyTelegram.Messenger.Services;
global using MyTelegram.Messenger.Services.Caching;
global using MyTelegram.Messenger.Services.IdGenerator;
global using MyTelegram.Messenger.Services.Interfaces;
global using MyTelegram.Messenger.TLObjectConverters.Interfaces;
global using MyTelegram.Queries;
global using MyTelegram.ReadModel;
global using MyTelegram.Schema;
global using MyTelegram.Schema.Account;
global using MyTelegram.Schema.Auth;
global using MyTelegram.Schema.Channels;
global using MyTelegram.Schema.Contacts;
global using MyTelegram.Schema.Extensions;
global using MyTelegram.Schema.Help;
global using MyTelegram.Schema.Messages;
global using MyTelegram.Services.Extensions;
global using MyTelegram.Services.Services;
global using MyTelegram.Services.TLObjectConverters;
global using System.Buffers;
global using System.Collections.Concurrent;
global using System.Diagnostics;
global using System.Diagnostics.CodeAnalysis;
global using System.Reflection;
global using System.Text;
global using System.Text.RegularExpressions;
global using System.Threading.Tasks;
global using MyTelegram.Domain.Aggregates.ChatInvite;
global using MyTelegram.Domain.Events.ChatInvite;
global using MyTelegram.Domain.Commands.ChatInvite;