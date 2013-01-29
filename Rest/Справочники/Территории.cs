
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/Territorii")]
	[Route("/Catalogs/Territorii/{Code}")]
	public class TerritoriiRequest/*����������������*/: V82.�����������������.����������,IReturn<TerritoriiRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class TerritoriiResponse//���������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/Territoriis")]
	[Route("/Catalogs/Territoriis/{Codes}")]
	public class TerritoriisRequest/*����������������*/: IReturn<List<TerritoriiRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public TerritoriisRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class TerritoriisResponse//���������������
	{
		public string Result {get;set;}
	}


	public class TerritoriiService /*����������������*/ : Service
	{
		public object Any(TerritoriiRequest request)
		{
			return new TerritoriiResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(TerritoriiRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.����������.�����������(���������);
				if (������ == null)
				{
					return new TerritoriiResponse() {Result = "���������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.����������.�����������(1);
			}
		}

		public object Get(TerritoriisRequest request)
		{
			var ��������� = new List<V82.�����������������.����������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.����������.�����������(���������);
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
