﻿// ---------------------------------------------------------------
// Copyright (c) Christo du Toit All rights reserved.
// Licensed under the MIT License.
// ---------------------------------------------------------------

using System.Threading.Tasks;
using CulDeSacApi.Brokers.Events;
using CulDeSacApi.Brokers.Storages;
using CulDeSacApi.Models.Students;

namespace CulDeSacApi.Services.Foundations.Students
{
    public class StudentService : IStudentService
    {
        private readonly IStorageBroker storageBroker;
        private readonly IEventBroker eventBroker;

        public StudentService(IStorageBroker storageBroker, IEventBroker eventBroker)
        {
            this.storageBroker = storageBroker;
            this.eventBroker = eventBroker;
        }

        public async ValueTask<Student> AddStudentAsync(Student student)
        {
            Student createdStudent = await storageBroker.InsertStudentAsync(student);
            await eventBroker.PublishStudentAddEventAsync(createdStudent);

            return createdStudent;
        }
    }
}
