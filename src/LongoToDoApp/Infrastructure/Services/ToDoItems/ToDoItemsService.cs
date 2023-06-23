﻿using LongoToDoApp.Infrastructure.Abstractions;
using LongoToDoApp.Infrastructure.Services.Base;
using LongoToDoApp.Infrastructure.Services.ToDoItems.Models;
using LongoToDoApp.Services.Abstractions;

namespace LongoToDoApp.Infrastructure.Services.ToDoItems
{
    public class ToDoItemsService : BaseApiService, IToDoItemsService
    {
		private const string GetToDoItemsEndpoint = "/todo";
        private const string AddItemEndpoint = "/todo";

        public ToDoItemsService(ICheckConnectivityService checkConnectivityService, HttpClientHandler handler) : base(checkConnectivityService, handler)
        {
            
        }

		public async Task<List<ToDoItemsResponse>> GetToDoItems(ToDoItemsRequest request)
        {
            return await HttpCall<ToDoItemsResponse, ToDoItemsRequest>(HttpMethod.Get, GetToDoItemsEndpoint, request);
        }

		public async Task<List<ToDoItemsResponse>> AddItem(AddItemRequest request)
		{
			return await HttpCall<ToDoItemsResponse, AddItemRequest>(HttpMethod.Post, AddItemEndpoint, request);
		}
	}
}
