
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/DokumentyRealizaciiPolnomochijjNalogovykhOrganov")]
	[Route("/Catalogs/DokumentyRealizaciiPolnomochijjNalogovykhOrganov/{Code}")]
	public class DokumentyRealizaciiPolnomochijjNalogovykhOrganovRequest/*���������������������������������������������������*/: V82.�����������������.���������������������������������������������,IReturn<DokumentyRealizaciiPolnomochijjNalogovykhOrganovRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class DokumentyRealizaciiPolnomochijjNalogovykhOrganovResponse//��������������������������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/DokumentyRealizaciiPolnomochijjNalogovykhOrganovs")]
	[Route("/Catalogs/DokumentyRealizaciiPolnomochijjNalogovykhOrganovs/{Codes}")]
	public class DokumentyRealizaciiPolnomochijjNalogovykhOrganovsRequest/*���������������������������������������������������*/: IReturn<List<DokumentyRealizaciiPolnomochijjNalogovykhOrganovRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public DokumentyRealizaciiPolnomochijjNalogovykhOrganovsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class DokumentyRealizaciiPolnomochijjNalogovykhOrganovsResponse//��������������������������������������������������
	{
		public string Result {get;set;}
	}


	public class DokumentyRealizaciiPolnomochijjNalogovykhOrganovService /*���������������������������������������������������*/ : Service
	{
		public object Any(DokumentyRealizaciiPolnomochijjNalogovykhOrganovRequest request)
		{
			return new DokumentyRealizaciiPolnomochijjNalogovykhOrganovResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(DokumentyRealizaciiPolnomochijjNalogovykhOrganovRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.���������������������������������������������.�����������(���������);
				if (������ == null)
				{
					return new DokumentyRealizaciiPolnomochijjNalogovykhOrganovResponse() {Result = "��������������������������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.���������������������������������������������.�����������(1);
			}
		}

		public object Get(DokumentyRealizaciiPolnomochijjNalogovykhOrganovsRequest request)
		{
			var ��������� = new List<V82.�����������������.���������������������������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.���������������������������������������������.�����������(���������);
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
