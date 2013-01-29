
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/OsnovaniyaIschislyaemogoTrudovogoStazha")]
	[Route("/Catalogs/OsnovaniyaIschislyaemogoTrudovogoStazha/{Code}")]
	public class OsnovaniyaIschislyaemogoTrudovogoStazhaRequest/*�����������������������������������������*/: V82.�����������������.�����������������������������������,IReturn<OsnovaniyaIschislyaemogoTrudovogoStazhaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class OsnovaniyaIschislyaemogoTrudovogoStazhaResponse//����������������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/OsnovaniyaIschislyaemogoTrudovogoStazhas")]
	[Route("/Catalogs/OsnovaniyaIschislyaemogoTrudovogoStazhas/{Codes}")]
	public class OsnovaniyaIschislyaemogoTrudovogoStazhasRequest/*�����������������������������������������*/: IReturn<List<OsnovaniyaIschislyaemogoTrudovogoStazhaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public OsnovaniyaIschislyaemogoTrudovogoStazhasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class OsnovaniyaIschislyaemogoTrudovogoStazhasResponse//����������������������������������������
	{
		public string Result {get;set;}
	}


	public class OsnovaniyaIschislyaemogoTrudovogoStazhaService /*�����������������������������������������*/ : Service
	{
		public object Any(OsnovaniyaIschislyaemogoTrudovogoStazhaRequest request)
		{
			return new OsnovaniyaIschislyaemogoTrudovogoStazhaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(OsnovaniyaIschislyaemogoTrudovogoStazhaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�����������������������������������.�����������(���������);
				if (������ == null)
				{
					return new OsnovaniyaIschislyaemogoTrudovogoStazhaResponse() {Result = "����������������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�����������������������������������.�����������(1);
			}
		}

		public object Get(OsnovaniyaIschislyaemogoTrudovogoStazhasRequest request)
		{
			var ��������� = new List<V82.�����������������.�����������������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�����������������������������������.�����������(���������);
					if (������ != null)
					{
						���������.Add(������);
					}
				}
			}
			return ���������;
		}

	}
}
