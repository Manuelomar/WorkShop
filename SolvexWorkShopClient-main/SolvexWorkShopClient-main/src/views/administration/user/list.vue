<template>
  <div>
    <sx-buefy-table  :config="tableConfig" >
        <template v-slot:name="{ row }" @click=paymentsDetails(row.loanId)>
        <div class="media">

        </div>
      </template>

      <template v-slot:Name="{ row }">
          {{ row.name || "empty"}}
      </template>

      <template v-slot:LastName="{ row }">
          {{ row.lastName }}
      </template>
      <template v-slot:Age="{ row }">
          {{ row.age }}
      </template>

    
      <template v-slot:detalles="{ row }">
        <div class="buttons is-centered">
          <b-button label="+ detalles" type="is-primary" outlined  @click="workshopDetails(row.loanId)"/>
        </div>
      </template>
    </sx-buefy-table>
  </div>
</template>

<script lang="ts">

import { Component, Mixins } from "vue-property-decorator";
import { SxBuefyTableMixin } from "@/mixins";
import { BTableColumn } from "@/components/sx/sx-buefy-table/config";
import Helpers from "@/core/utils/helpers";
import { BTableColumnType, UserRole } from "@/core/utils/enums";
import { Users } from "@/core/model/users.model";
import axios from "axios";
import settings from "@/core/utils/app-settings";


@Component
export default class UsersListComponent extends Mixins<
  SxBuefyTableMixin<Users>
>(SxBuefyTableMixin) {
  
 async created() {
    this.setTableConfig();
    this.formatColumns();
    console.log(this.tableConfig)
    const get = await axios.get(settings.API_URL + "api/User")
  }
  setTableConfig() {
    this.tableConfig.controller = "User";
    this.tableConfig.aggregatable = true;
    this.tableConfig.aggregating.title = "Users";
    
  
  }
  formatColumns() {

    let Name = new BTableColumn("Name", "Name");
    Name.sortable = false;
    Name.customTemplate = true;

    let LastName = new BTableColumn("LastName", " LastName");
    LastName.sortable = false;
    LastName.customTemplate = true;

    let Age = new BTableColumn("Age", "Age");
    Age.sortable = false;
    Age.customTemplate = true;


    this.tableConfig.insertColumns( Name, LastName, Age);
  }
}
</script>