﻿using Azure.Core;
using Dominio;
using Dominio.Model;
using Microsoft.EntityFrameworkCore;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class AlunoService : IAlunoService
    {
        private readonly App_DbContext dbcontext;

        public AlunoService(App_DbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        public async Task<bool> Create(Aluno dados)
        {
            try
            {
                dbcontext.Aluno.Add(dados);
                await dbcontext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> Delete(int Id)
        {
            try
            {
                Aluno result = await GetIdAlunos(Id);
                dbcontext.Aluno.Remove(result);
                await dbcontext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        
        public async Task<IEnumerable<Aluno>> GetAlunos()
        {
            try
            {
                return await dbcontext.Aluno.ToListAsync();
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public async Task<IEnumerable<Aluno>> GetAlunos(string Nome)
        {
            throw new NotImplementedException();
        }

        public async Task<Aluno> GetIdAlunos(int codigo)
        {
            try
            {               
                return dbcontext.Aluno.Where(x => x.Id == codigo)?.FirstOrDefault(); ;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<Aluno> Update()
        {
            throw new NotImplementedException();
        }
    }
}
