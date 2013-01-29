
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/NalogovyeOrgany")]
	[Route("/Catalogs/NalogovyeOrgany/{Code}")]
	public class NalogovyeOrganyRequest/*���������������������*/: V82.�����������������.���������������,IReturn<NalogovyeOrganyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class NalogovyeOrganyResponse//��������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/NalogovyeOrganys")]
	[Route("/Catalogs/NalogovyeOrganys/{Codes}")]
	public class NalogovyeOrganysRequest/*���������������������*/: IReturn<List<NalogovyeOrganyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public NalogovyeOrganysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class NalogovyeOrganysResponse//��������������������
	{
		public string Result {get;set;}
	}


	public class NalogovyeOrganyService /*���������������������*/ : Service
	{
		public object Any(NalogovyeOrganyRequest request)
		{
			return new NalogovyeOrganyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(NalogovyeOrganyRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.���������������.�����������(���������);
				if (������ == null)
				{
					return new NalogovyeOrganyResponse() {Result = "��������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.���������������.�����������(1);
			}
		}

		public object Get(NalogovyeOrganysRequest request)
		{
			var ��������� = new List<V82.�����������������.���������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.���������������.�����������(���������);
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
