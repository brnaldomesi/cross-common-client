﻿using System;
using System.Globalization;
using System.IO;
using Microsoft.AspNetCore.Http;

using NodaTime;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Helpers
{
    public class ExcelHelper
    {
        public ISheet GetFirstSheet(IFormFile formFile)
        {
            ISheet sheet = null;

            var extension = Path.GetExtension(formFile.FileName).ToLower();

            using (var stream = formFile.OpenReadStream())
            {
                if (extension == ".xls")
                {
                    var workbook = new HSSFWorkbook(stream);
                    sheet = workbook.GetSheetAt(0);
                }
                else if (extension == ".xlsx")
                {
                    var workbook = new XSSFWorkbook(stream);
                    sheet = workbook.GetSheetAt(0);
                }
            }

            return sheet;
        }

        public string GetValue(IRow row, int index)
        {
            var cell = row.GetCell(index);
            if (cell == null)
            {
                return string.Empty;
            }

            try
            {
                return cell.StringCellValue;
            }
            catch (Exception e)
            {
                return cell.NumericCellValue.ToString(CultureInfo.InvariantCulture);
            }
        }

        public double GetValueNumeric(IRow row, int index)
        {
            var cell = row.GetCell(index);
            if (cell == null)
            {
                return 0;
            }

            return cell.NumericCellValue;
        }

        public Instant GetValueDatetime(IRow row, int index)
        {
            var cell = row.GetCell(index);
            if (cell == null)
            {
                return Instant.MinValue;
            }

            try
            {
                return Instant.FromDateTimeUtc(cell.DateCellValue);
            }
            catch (Exception e)
            {
                try
                {
                    return new DatetimeHelper().GetInstantFromString(cell.StringCellValue, "dd/MM/yyyy");

                }
                catch (Exception ex)
                {
                    return Instant.MinValue;
                }
            }
        }
    }
}