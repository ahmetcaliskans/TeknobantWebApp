﻿using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    public class CollectionDefinitionController : Controller
    {
        ICollectionDefinitionService _collectionDefinitionService;

        public CollectionDefinitionController(ICollectionDefinitionService collectionDefinitionService)
        {
            _collectionDefinitionService = collectionDefinitionService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            RoleOperation roleOperation = new RoleOperation("CollectionDefinition.Show");
            roleOperation.fn_checkRole();
            var result = _collectionDefinitionService.GetListWithDetails();
            return View(result.Data);
        }

        [HttpGet]
        public IActionResult GetCollectionDefinitionById(int id)
        {
            var result = _collectionDefinitionService.GetByIdWithDetails(id);
            if (result.Success)
            {
                return PartialView("AddEditCollectionDefinition", result.Data);
            }

            return PartialView("AddEditCollectionDefinition", null);

        }

        [HttpPost]
        public IActionResult AddcollectionDefinition(CollectionDefinition collectionDefinition)
        {
            IResult result;
            if (collectionDefinition.Id == null || collectionDefinition.Id <= 0)
                result = _collectionDefinitionService.Add(collectionDefinition);
            else
                result = _collectionDefinitionService.Update(collectionDefinition);

            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);


        }

        [HttpPost]
        public IActionResult DeleteCollectionDefinitionById(int id)
        {
            var _collectionDefinitionResult = _collectionDefinitionService.GetByIdWithDetails(id);

            var result = _collectionDefinitionService.Delete(_collectionDefinitionResult.Data);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);


        }
    }
}
