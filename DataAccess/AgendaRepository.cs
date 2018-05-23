﻿using Entities;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace DataAccess
{
    public class AgendaRepository : IRepository<Agenda>
    {
        public void Add(Agenda entity)
        {
            using (FriendContext context = new FriendContext())
            {
                context.Agendas.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(Agenda entity)
        {
            using (FriendContext context = new FriendContext())
            {
                context.Agendas.Remove(entity);
            }
        }

        public Agenda Get(Guid id)
        {
            using (FriendContext context = new FriendContext())
            {
                return context.Agendas.FirstOrDefault(a => a.Id == id);
            }
        }

        public IEnumerable<Agenda> GetAll()
        {
            using (FriendContext context = new FriendContext())
            {
                return context.Agendas;
            }
        }

        public void Modify(Agenda entity)
        {
            using (FriendContext context = new FriendContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
