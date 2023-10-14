using System;
using App.Models;
using App.Controllers;

namespace Services
{

	public class AddDataService
	{
		private List<TransferDataModel> _dataList = new List<TransferDataModel>();

		public void Add(TransferDataModel transferdatamodel)
		{
			_dataList.Add(transferdatamodel);
		}

		
	}
}

