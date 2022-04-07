﻿using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class BinaryActivoRepository : IActivoModel
    {
        public RAFContext context;
        public const int SIZE = 119;
        public BinaryActivoRepository()
        {
            context = new RAFContext("activo", SIZE);
        }
        public void Add(Activo t)
        {
            try
            {
                context.Create<Activo>(t);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(Activo t)
        {

            try
            {
                return context.Delete<Activo>(t);
            }
            catch (Exception)
            {
                throw;
            }
        }
            public Activo GetById(int id)
        {

            try
            {
                return context.Get<Activo>(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Activo> Read()
        {

            try
            {
                return context.GetAll<Activo>();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int Update(Activo t)
        {
            try
            {
                return context.Update<Activo>(t);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AsignarActivo(Activo a, Empleado b)
        {
            a.Empleado = b;
        }

      
    }
}
