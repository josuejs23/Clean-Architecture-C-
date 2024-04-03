using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Domain.Primitives;

public record DoaminEvent(Guid Id) : INotification;
