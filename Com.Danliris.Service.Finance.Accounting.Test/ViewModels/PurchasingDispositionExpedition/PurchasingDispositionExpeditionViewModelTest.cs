﻿using Com.Danliris.Service.Finance.Accounting.Lib.ViewModels.IntegrationViewModel;
using Com.Danliris.Service.Finance.Accounting.Lib.ViewModels.PurchasingDispositionExpedition;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Com.Danliris.Service.Finance.Accounting.Test.ViewModels.PurchasingDispositionExpedition
{
    public class PurchasingDispositionExpeditionViewModelTest
    {
        [Fact]
        public void should_Success_Instantiate()
        {
            PurchasingDispositionExpeditionViewModel viewModel = new PurchasingDispositionExpeditionViewModel()
            {
                bankExpenditureNoteDate = DateTimeOffset.Now,
                bankExpenditureNoteNo = "bankExpenditureNoteNo",
                bankExpenditureNotePPHDate = DateTimeOffset.Now,
                bankExpenditureNotePPHNo = "bankExpenditureNotePPHNo",
                cashierDivisionBy = "cashierDivisionBy",
                cashierDivisionDate = DateTimeOffset.Now,
                dispositionDate = DateTimeOffset.Now,
                category = new CategoryViewModel()
                {
                    code = "code",
                    name = "name"
                },
                currency = new CurrencyViewModel(),
                dispositionNo = "dispositionNo",
                incomeTax = 1,
                division = new DivisionViewModel()
            };

            Assert.True(DateTimeOffset.MinValue < viewModel.bankExpenditureNoteDate);
            Assert.Equal("bankExpenditureNoteNo", viewModel.bankExpenditureNoteNo);
            Assert.True(DateTimeOffset.MinValue <viewModel.bankExpenditureNotePPHDate);
            Assert.True(DateTimeOffset.MinValue <viewModel.cashierDivisionDate);
            Assert.True(DateTimeOffset.MinValue < viewModel.dispositionDate);
            Assert.Equal("dispositionNo", viewModel.dispositionNo);
            Assert.NotNull(viewModel.currency);
            Assert.Equal(1, viewModel.incomeTax);
            Assert.NotNull(viewModel.division);
        }
    }
}
