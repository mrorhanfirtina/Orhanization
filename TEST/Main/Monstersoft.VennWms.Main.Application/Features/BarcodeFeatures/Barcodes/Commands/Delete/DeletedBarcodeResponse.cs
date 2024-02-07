﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Commands.Delete;

public class DeletedBarcodeResponse
{
    public string Code { get; set; }
    public string DepositorCode { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }
}
