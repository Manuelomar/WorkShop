<template>

  <div>
    <sx-buefy-table :config="tableConfig">

      <template v-slot:name="{ row }" @click=userDetails(row.id)>
        <div class="media">

          <div class="media-left">
            <p class="icon-image-rounded has-background-primary">W</p>
          </div>

          <div class="media-content">
            <p class="title is-6">
              <b-tooltip label="Usuario no disponible">
                <a class="has-text-link cursor-ban">{{ row.Name }}</a>
              </b-tooltip>
            </p>
            
          </div>
        </div>
      </template>

      <template v-slot:LastName="{ row }">
        <p class="subtitle is-6">
          {{ row.LastName }}
        </p>
      </template>

      <template v-slot:Age="{ row }">
        <p class="subtitle is-6">
          {{ row.Age }}
        </p>
      </template>

      <template v-slot:addMember="{ row }">
        <div class="buttons is-centered">
          <b-button label="+" type="is-primary" outlined @click="addMember(row.id)"/>
        </div>
      </template>

      <template v-slot:detalles="{ row }">
        <div class="buttons is-centered">
          <b-button label="+ detalles" type="is-primary" outlined  @click="userDetails(row.id)"/>
        </div>
      </template>

      <b-modal v-if="isCardModalActive === true" :width="640" scroll="keep">
        <div class="card">
          <div class="card-content">
            <p>{{ selectedUser.Name }} / {{ selectedUser.LastName }} / {{ selectedUser.Age }}</p> <br/>
          </div>
        </div>
      </b-modal>

    </sx-buefy-table>
  </div>
</template>

<script lang="ts">
import { Component, Mixins } from "vue-property-decorator";
import { SxBuefyTableMixin } from "@/mixins";
import { BTableColumn } from "@/components/sx/sx-buefy-table/config";
import { WorkShop } from "@/core/model";
import axios from "axios";
import settings from "@/core/utils/app-settings";

@Component({

})
export default class UserListComponent extends Mixins<SxBuefyTableMixin<WorkShop>>(SxBuefyTableMixin) {
  


  created() {
    this.setTableConfig();
    this.formatColumns();
  }
  setTableConfig() {
    this.tableConfig.controller = "User";
    this.tableConfig.aggregatable = true;
    this.tableConfig.aggregating.title = "Listado de usurios";
  }
  formatColumns() {
    const Name = new BTableColumn("name", "Name");
    Name.customTemplate = true;
    
    const LastName = new BTableColumn("lastName", "Apellido");
    LastName.customTemplate = true;

    const Age = new BTableColumn("Age", "Edad");
    Age.customTemplate = true;

    this.tableConfig.insertColumns(Name,LastName,Age);
  }
  isCardModalActive: boolean = false;
  selectedUser = [];

  async userDetails(id: number){
    const resuser = await axios.get(settings.API_URL + `api/user/${id}`);
    this.selectedUser = resuser.data;
    this.isCardModalActive = true;
  }

  addDay(id: number){
    this.$router.push(
      `${this.$router.currentRoute.path}/addDay/${id}`
    );
  }

  addMember(id: number){
    this.$router.push(
      `${this.$router.currentRoute.path}/addMember/${id}`
    );
  }
}
</script>