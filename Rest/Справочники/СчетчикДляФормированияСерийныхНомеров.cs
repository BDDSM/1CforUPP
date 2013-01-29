
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/SchetchikDlyaFormirovaniyaSerijjnykhNomerov")]
	[Route("/Catalogs/SchetchikDlyaFormirovaniyaSerijjnykhNomerov/{Code}")]
	public class SchetchikDlyaFormirovaniyaSerijjnykhNomerovRequest/*�������������������������������������������*/: V82.�����������������.�������������������������������������,IReturn<SchetchikDlyaFormirovaniyaSerijjnykhNomerovRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class SchetchikDlyaFormirovaniyaSerijjnykhNomerovResponse//������������������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/SchetchikDlyaFormirovaniyaSerijjnykhNomerovs")]
	[Route("/Catalogs/SchetchikDlyaFormirovaniyaSerijjnykhNomerovs/{Codes}")]
	public class SchetchikDlyaFormirovaniyaSerijjnykhNomerovsRequest/*�������������������������������������������*/: IReturn<List<SchetchikDlyaFormirovaniyaSerijjnykhNomerovRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public SchetchikDlyaFormirovaniyaSerijjnykhNomerovsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class SchetchikDlyaFormirovaniyaSerijjnykhNomerovsResponse//������������������������������������������
	{
		public string Result {get;set;}
	}


	public class SchetchikDlyaFormirovaniyaSerijjnykhNomerovService /*�������������������������������������������*/ : Service
	{
		public object Any(SchetchikDlyaFormirovaniyaSerijjnykhNomerovRequest request)
		{
			return new SchetchikDlyaFormirovaniyaSerijjnykhNomerovResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(SchetchikDlyaFormirovaniyaSerijjnykhNomerovRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�������������������������������������.�����������(���������);
				if (������ == null)
				{
					return new SchetchikDlyaFormirovaniyaSerijjnykhNomerovResponse() {Result = "������������������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�������������������������������������.�����������(1);
			}
		}

		public object Get(SchetchikDlyaFormirovaniyaSerijjnykhNomerovsRequest request)
		{
			var ��������� = new List<V82.�����������������.�������������������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�������������������������������������.�����������(���������);
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
