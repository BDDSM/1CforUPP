
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/MedicinskieStrakhovyePolisy")]
	[Route("/Catalogs/MedicinskieStrakhovyePolisy/{Code}")]
	public class MedicinskieStrakhovyePolisyRequest/*��������������������������������*/: V82.�����������������.��������������������������,IReturn<MedicinskieStrakhovyePolisyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class MedicinskieStrakhovyePolisyResponse//�������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/MedicinskieStrakhovyePolisys")]
	[Route("/Catalogs/MedicinskieStrakhovyePolisys/{Codes}")]
	public class MedicinskieStrakhovyePolisysRequest/*��������������������������������*/: IReturn<List<MedicinskieStrakhovyePolisyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public MedicinskieStrakhovyePolisysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class MedicinskieStrakhovyePolisysResponse//�������������������������������
	{
		public string Result {get;set;}
	}


	public class MedicinskieStrakhovyePolisyService /*��������������������������������*/ : Service
	{
		public object Any(MedicinskieStrakhovyePolisyRequest request)
		{
			return new MedicinskieStrakhovyePolisyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(MedicinskieStrakhovyePolisyRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������������������������.�����������(���������);
				if (������ == null)
				{
					return new MedicinskieStrakhovyePolisyResponse() {Result = "�������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������������������������.�����������(1);
			}
		}

		public object Get(MedicinskieStrakhovyePolisysRequest request)
		{
			var ��������� = new List<V82.�����������������.��������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.��������������������������.�����������(���������);
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
