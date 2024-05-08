﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PetShelter.Services.ViewModels;
using PetShelter.Shared;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using PetShelter.Shared.Services.Contracts;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PetShelterMVC.Controllers
{
    public abstract class BaseCrudController<TModel, TRepository, TService, TEditVM, TDetailsVM> : Controller
        where TModel : BaseModel
        where TRepository : IBaseRepository<TModel>
        where TService : IBaseCrudService<TModel, TRepository>
        where TEditVM : BaseModel, new()
        where TDetailsVM : BaseVM
    {
        protected readonly TService _service;
        protected readonly IMapper _mapper;

        protected BaseCrudController(TService service, IMapper _mapper)
        {
            this._service = service;
            _mapper = _mapper;
        }

        protected const int DefaultPageSize = 10;
        protected const int DefaultPageNumber = 1;
        protected const int MaxPageSize = 100;

        public virtual Task<string?> Valdiate(TEditVM editVM)
        {
            return Task.FromResult<string?>(null);
        }

        public virtual Task<TEditVM> PrePopulateVMAsync()
        {
            return Task.FromResult(new TEditVM());
        }
        [HttpGet]

        public virtual async Task<IActionResult> List(
            int pageSize = DefaultPageSize,
            int pageNumber = DefaultPageNumber)
        {
            if (pageSize <= 0 || pageSize > MaxPageSize || pageNumber <= 0)
            {
                return BadRequest(Constants.InvalidPagination);
            }
            var models = await this._service.GetWithPaginationAsync(pageSize, pageNumber);
            var mappedModels = _mapper.Map<IEnumerable<TDetailsVM>>(models);
            return View(nameof(List), mappedModels);
        }

        [HttpGet]
        public virtual async Task<IActionResult> Details(int id)
        {
            var model = await this._service.GetByIdIfExistsAsync(id);
            if (model == default)
            {
                return BadRequest(Constants.InvalidId);
            }
            var mappedModel = _mapper.Map<TDetailsVM>(model);
            return View(mappedModel);

        }

        [HttpGet]
        public virtual async Task<IActionResult> Create()
        {
            var editVM = await PrePopulateVMAsync();
            return View(editVM);
        }

        [HttpPost]
        public virtual async Task<IActionResult> Create(TEditVM editVM)
        {
            var errors = await Valdiate(editVM);
            if (errors != null)
            {
                return View(editVM);
            }
            var model = this._mapper.Map<TModel>(editVM);
            await this._service.SaveAsync(model);
            return await List();
        }
        [HttpGet]
        public virtual async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return BadRequest(Constants.InvalidId);
            }
            var model = await this._service.GetByIdIfExistsAsync(id.Value);
            if (model == default)
            {
                return BadRequest(Constants.InvalidId);
            }
            var mappedModel = _mapper.Map<TEditVM>(model);
            return View(mappedModel);
        }

    }
}
